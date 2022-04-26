import axios from "axios";
import { ToastProgrammatic as Toast } from "buefy";

const baseDomain = process.env.VUE_APP_BaseDomain;
const baseURL = `${baseDomain}`;

const instance = axios.create({
  baseURL: baseURL,
  headers: {
    // "Authorization": "Bearer xxxxx"
  }
});

instance.interceptors.response.use(
  function(response) {
    return response;
  },
  function(error) {
    Toast.open({
      duration: 3000,
      message: error.response.data,
      position: "is-bottom",
      type: "is-danger"
    });
  }
);
export default instance;
