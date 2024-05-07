self.addEventListener('install', event => {
    event.waitUntil(
        caches.open('my-cache-v1').then(cache => {
            return cache.addAll([
                '/',
                '/index.html',
                '/css/app.css',
                '/js/app.js',
                '/sample-data/weather.json'
            ]);
        })
    );
});

self.addEventListener('fetch', event => {
    event.respondWith(
        caches.match(event.request).then(response => {
            return response || fetch(event.request);
        })
    );
});
