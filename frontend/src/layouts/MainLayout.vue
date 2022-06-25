<template>
  <div id="q-app" style="min-height: 100vh">
    <div class="q-pa-md">
      <q-layout view="lHh Lpr lFf">
        <q-header elevated class="bg-dark">
          <q-toolbar>
            <q-btn
              flat
              round
              dense
              icon="menu"
              class="q-mr-sm"
              @click="toggleLeftDrawer"
            ></q-btn>
            <q-toolbar-title style="text-align: center">
              Interlude
            </q-toolbar-title>
            <q-btn round dense icon="refresh" class="q-mr-md"></q-btn>
            <q-btn round dense icon="logout" class="q-mr-sm"></q-btn>
          </q-toolbar>
        </q-header>

        <q-drawer
          class="bg-dark text-white"
          v-model="drawer"
          show-if-above="false"
          bordered
          :width="200"
          :breakpoint="400"
        >
          <q-img
            class="absolute-top"
            src="https://cdn.quasar.dev/img/material.png"
            style="height: 150px"
          >
            <div class="absolute-bottom bg-transparent">
              <q-avatar size="56px" class="q-mb-sm">
                <img src="https://cdn.quasar.dev/img/boy-avatar.png" />
              </q-avatar>
              <div class="text-weight-bold">Hüseyin Hamad</div>
              <div>@huseyinhamad</div>
            </div>
          </q-img>
          <q-scroll-area
            style="
              height: calc(100% - 150px);
              margin-top: 150px;
              border-right: 1px solid #ddd;
            "
          >
            <q-list class="text-white" padding>
              <DrawerLinks
                v-for="link in drawerLinks"
                :key="link.title"
                v-bind="link"
              />
            </q-list>
          </q-scroll-area>
        </q-drawer>

        <q-page-container>
          <router-view />
        </q-page-container>
      </q-layout>
    </div>
  </div>
</template>

<script>
import { defineComponent, ref } from "vue";
import DrawerLinks from "src/components/DrawerLinks.vue";

const linksList = [
  {
    title: "Home",
    icon: "home",
    link: "#/home",
  },
  {
    title: "Profile",
    icon: "account_circle",
    link: "#/profile",
  },
];

export default defineComponent({
  name: "MainLayout",

  components: {
    DrawerLinks,
  },

  setup() {
    const drawer = ref(false);

    return {
      drawerLinks: linksList,
      drawer,
      toggleLeftDrawer() {
        drawer.value = !drawer.value;
      },
    };
  },
});
</script>
