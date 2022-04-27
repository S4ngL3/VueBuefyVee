<template>
    <ValidationObserver ref="observer" v-slot="{ handleSubmit, reset }">
        <form @submit.prevent="handleSubmit(submit)" @reset.prevent="reset" :model="groupTask">
            <ValidationProvider :rules="{ required: true, maximum: { iMax: 50 }}" name="GroupName" v-slot="{ errors, valid }">
                <b-field
                    :type="{ 'is-danger': errors[0], 'is-success': valid }"
                    :message="errors"
                >
                    <template #label>
                        Tên nhóm <span class="has-text-danger">*</span>
                    </template>
                    <b-input type="input" v-model="groupTask.StrName"
                    placeholder="Tên nhóm công việc"></b-input>
                </b-field>
            </ValidationProvider>
            <b-field>
                <b-input type="textarea"
                    minlength="10"
                    maxlength="100"
                    placeholder="Nhập mô tả"
                    v-model="groupTask.StrDescriptions">
                </b-input>
            </b-field>
            <div class="buttons">
                <ValidationProvider rules="required" name="applyObject" v-slot="{ errors, valid }">
                    <b-field
                    :message="errors"
                    :type="{ 'is-danger': errors[0], 'is-success': valid }"
                    >
                    <template #label>
                        Đối tượng áp dụng <span class="has-text-danger">*</span>
                    </template>
                    <b-select placeholder="Chọn đối tượng" v-model="groupTask.IntObjectFor">
                        <option value="1">Quản lý</option>
                        <option value="2">PGD</option>
                    </b-select>
                    </b-field>
                </ValidationProvider>
                <ValidationProvider rules="required" name="type" v-slot="{ errors, valid }">
                    <b-field
                    :message="errors"
                    :type="{ 'is-danger': errors[0], 'is-success': valid }"
                    >
                    <template #label>
                        Loại hình <span class="has-text-danger">*</span>
                    </template>
                    <b-select placeholder="Chọn loại hình" v-model="groupTask.IntGroupFor">
                        <option value="1">Kinh doanh</option>
                        <option value="2">Markting</option>
                    </b-select>
                    </b-field>
                </ValidationProvider>
                <ValidationProvider rules="required|greaterthan" name="order" v-slot="{ errors, valid }">
                    <b-field
                        :type="{ 'is-danger': errors[0], 'is-success': valid }"
                        :message="errors"
                    >
                        <template #label>
                            Thứ tự hiển thị <span class="has-text-danger">*</span>
                        </template>
                        <b-field>
                            <b-input type="input" v-model="groupTask.IntGroupBy" placeholder="Thứ tự hiển thị"></b-input>
                        </b-field>
                    </b-field>
                </ValidationProvider>
            </div>

            <div class="buttons">
                <button class="button is-success" type="submit">
                    <!-- <span class="icon is-small">
                        <i class="fas fa-check"></i>
                    </span> -->
                    <span>Submit</span>
                </button>
                <button class="button" @click="resetForm">
                    <!-- <span class="icon is-small">
                        <i class="fas fa-redo"></i>
                    </span> -->
                    <span>Reset</span>
                </button>
            </div>
        </form>
    </ValidationObserver>
</template>
<script>
import { ValidationObserver, ValidationProvider } from 'vee-validate';
import Repository from "@/repositories/Repository.vue";

export default {
    name: "BuefyForm",
    components: {
        ValidationObserver,
        ValidationProvider
    },
    data(){
        return {
            groupTask: {
                StrName:'',
                StrDescriptions: '',
                IntObjectFor: '',
                IntGroupFor:'',
                IntGroupBy: 0
            }
        };
    },
    methods: {
        submit() {
            console.log(JSON.stringify(this.groupTask));

            try{
                Repository.post('/api/v1/GroupTask/WriteGroupTask', this.groupTask)
                .then((res) => {
                    //console.log(res);
                    this.$buefy.toast.open({
                        duration: 5000,
                        message: res.data.Message,
                        position: 'is-bottom',
                        type: 'is-danger'
                    })
                })
            }
            catch(error){
                console.log(error);
            }
        },
        resetForm() {
            this.StrName = '';
            this.StrDescriptions = '';
            this.IntObjectFor = '';
            this.IntGroupFor = '';
            this.IntGroupBy = 0;
            requestAnimationFrame(() => {
                this.$refs.observer.reset();
            })
        }
    }
}
</script>
