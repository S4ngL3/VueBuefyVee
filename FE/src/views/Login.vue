<template>
  <div class="about">
    <h1>Đăng nhập</h1>
    <div class="column is-4 is-offset-4">
      <b-field label="Tài khoản">
        <b-input type="text" v-model="user.UserName" />
      </b-field>
      <b-field label="Mật khẩu">
        <b-input type="password" password-reveal v-model="user.PassWord" />
      </b-field>
      <b-button @click="login">Đăng nhập</b-button>
    </div>
  </div>
</template>

<script>
import Repository from "@/repositories/Repository.vue";
export default {
  name: "Login",
  data() {
    return {
      user: {
        UserName: null,
        PassWord: null,
        UserFullName: "string",
        PositionName: "string",
        UserId: 0,
        LastLogIn: 0,
        PathAvatar: "string",
        IsLeader: true,
        GroupID: 0,
        Token: "string",
        Latitude: 0,
        Longitude: 0,
        ActionName: "string",
        Description: "string",
        DeviceId: "string",
        Fcm_id: "string",
        Id: 0,
        CreatedDate: 0,
        CreatedDateUnix: 0,
        UpdatedDate: 0,
        UpdatedDateUnix: 0
      }
    };
  },
  mounted() {
    // console.log(Repository);
  },
  methods: {
    async login() {
      const data = await Repository.post("User/Login", this.user);
      if(data === undefined)
        return;
    }
  }
};
</script>

<style scoped>
.field {
  text-align: left;
}
</style>
