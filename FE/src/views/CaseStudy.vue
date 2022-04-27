<template>
  <div class="home">
      <Form/>
      <!-- <FormServerValidate/> -->
  </div>
</template>

<script>
// @ is an alias to /src
import Form from "@/components/Form";
// import FormServerValidate from "@/components/FormServerValidate";

export default {
  name: "Home",
  components: {
    Form,
    // FormServerValidate
  }
};
</script>