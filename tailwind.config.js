// noinspection JSUnresolvedReference

const defaultTheme = require('tailwindcss/defaultTheme');

/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./../**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            fontFamily: {
                sans: ['Inter var', ...defaultTheme.fontFamily.sans],
            }
        }
    },
    plugins: [],
}

