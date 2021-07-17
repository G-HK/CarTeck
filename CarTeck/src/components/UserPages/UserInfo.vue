<template>
    <div>
        <p>It's Me Mario</p>
        <span> {{ $route.params.UserID  }} </span>
    </div>
</template>
<script>
export default {
    name: 'USerInfo',
}
</script>