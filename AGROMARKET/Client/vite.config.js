import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig({
  server: {
    proxy: {
      //'/api/v1': 'http://localhost:3500', //testing
      '/api/v1': 'https://agromarket-production.up.railway.app', //production
    },
  },
  plugins: [react()]
})