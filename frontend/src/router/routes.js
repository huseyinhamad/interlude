const routes = [
  {
    path: "/",
    component: () => import("layouts/MainLayout.vue"),
    children: [
      { path: "/home", component: () => import("pages/HomePage.vue") },
    ],
  },
  {
    path: "/profile",
    component: () => import("layouts/MainLayout.vue"),
    children: [
      { path: "/profile", component: () => import("pages/ProfilePage.vue") },
    ],
  },
];

export default routes;
