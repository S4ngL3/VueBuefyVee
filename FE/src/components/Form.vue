<template>
    <ValidationObserver ref="observer" v-slot="{ handleSubmit }">
        <section class="section">
            <ValidationProvider rules="required|max:50" name="GroupName" v-slot="{ errors, valid }">
                <b-field
                    :type="{ 'is-danger': errors[0], 'is-success': valid }"
                    :message="errors"
                >
                    <template #label>
                        Tên nhóm <span class="has-text-danger">*</span>
                    </template>
                    <b-input type="input" v-model="groupName"
                    placeholder="Tên nhóm công việc"></b-input>
                </b-field>
            </ValidationProvider>
            <b-field>
                <b-input type="textarea"
                    minlength="10"
                    maxlength="100"
                    placeholder="Nhập mô tả">
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
                    <b-select placeholder="Chọn đối tượng" v-model="applyObject">
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
                    <b-select placeholder="Chọn loại hình" v-model="type">
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
                            <b-input type="input" v-model="order" placeholder="Thứ tự hiển thị"></b-input>
                        </b-field>
                    </b-field>
                </ValidationProvider>
            </div>

            <div class="buttons">
                <button class="button is-success" @click="handleSubmit(submit)">
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
        </section>
    </ValidationObserver>
</template>
<script>
import { ValidationObserver, ValidationProvider } from 'vee-validate'

export default {
    name: "BuefyForm",
    components: {
        ValidationObserver,
        ValidationProvider
    },
    data: () => ({
        groupName:'',
        description: '',
        applyObject: '',
        type:'',
        order: 0
    }),
    methods: {
        submit() {
            console.log('Form submitted');
        },
        resetForm() {
            this.groupName = '';
            this.description = '';
            this.applyObject = '';
            this.type = '';
            this.order = 0;
            requestAnimationFrame(() => {
                this.$refs.observer.reset();
            })
        }
    }
}
</script>
