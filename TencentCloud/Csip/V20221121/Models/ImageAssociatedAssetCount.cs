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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageAssociatedAssetCount : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>镜像关联主机数</p>
        /// </summary>
        [JsonProperty("HostCount")]
        public ulong? HostCount{ get; set; }

        /// <summary>
        /// <p>镜像关联容器数</p>
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// <p>镜像所属账号名</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>镜像所属账号appid</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>镜像所属账号uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
        }
    }
}

