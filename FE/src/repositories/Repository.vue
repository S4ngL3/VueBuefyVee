<script>
import Client from "./AxiosClient";

export default {
  get(url) {
    return Client.get(`${url}`);
  },
  post(url, obj) {
    return Client.post(`${url}`, obj);
  },
  update(url, id, obj) {
    return Client.put(`${url}/${id}`, obj);
  },
  delete(url, id) {
    return Client.delete(`${url}/${id}`);
  }
};
</script>
