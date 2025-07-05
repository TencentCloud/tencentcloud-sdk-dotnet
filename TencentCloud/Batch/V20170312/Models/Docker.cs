/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Docker : AbstractModel
    {
        
        /// <summary>
        /// Docker Hub填写“[user/repo]:[tag]”，Tencent Registry填写“ccr.ccs.tencentyun.com/[namespace/repo]:[tag]”
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Docker Hub 用户名或 Tencent Registry 用户名；公共镜像可不填写此参数。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Docker Hub 密码或 Tencent Registry 密码；公共镜像可不填写此参数。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Docker Hub 可以不填，但确保具有公网访问能力。或者是 Tencent Registry 服务地址“ccr.ccs.tencentyun.com”
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 拉取Docker镜像重试次数。默认值：0。
        /// </summary>
        [JsonProperty("MaxRetryCount")]
        public ulong? MaxRetryCount{ get; set; }

        /// <summary>
        /// 拉取Docker镜像失败时延迟时间。单位：秒。
        /// </summary>
        [JsonProperty("DelayOnRetry")]
        public ulong? DelayOnRetry{ get; set; }

        /// <summary>
        /// Docker命令运行参数。
        /// </summary>
        [JsonProperty("DockerRunOption")]
        public string DockerRunOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "MaxRetryCount", this.MaxRetryCount);
            this.SetParamSimple(map, prefix + "DelayOnRetry", this.DelayOnRetry);
            this.SetParamSimple(map, prefix + "DockerRunOption", this.DockerRunOption);
        }
    }
}

