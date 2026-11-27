/** @type {import('tailwindcss').Config} */
export default {
  content: ['./index.html', './src/**/*.{ts,tsx}'],
  theme: {
    extend: {
      colors: {
        primario: { DEFAULT: '#4F46E5', oscuro: '#4338CA', suave: '#EEF2FF' },
        lateral: '#1E1B4B',
        exito: '#16A34A',
        advertencia: '#D97706',
        peligro: '#DC2626',
        fondo: '#F8FAFC',
      },
      fontFamily: { sans: ['Inter', 'system-ui', 'sans-serif'] },
      borderRadius: { tarjeta: '10px' },
    },
  },
  plugins: [],
}
