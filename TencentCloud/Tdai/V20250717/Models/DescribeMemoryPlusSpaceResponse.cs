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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMemoryPlusSpaceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Memory 实例 ID。</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Memory 实例的自定义名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Memory 实例的简要描述，包括使用场景、用途或背景信息，便于日常运维识别。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>腾讯云账号的 APPID。</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Memroy 实例所属地域。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Memory 实例的标签信息。</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Memory 实例当前运行状态。</p><ul><li>1：运行中。</li><li>2：创建中。</li><li>3：销毁中。</li><li>4：已销毁。</li><li>5：隔离中。</li><li>6：已隔离。</li><li>7：恢复中。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Memory 实例计费模式。</p><ul><li>-1：免费体验。</li><li>0：包年包月。</li><li>1：按量计费。</li></ul>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>是否自动续费</p><p>枚举值：</p><ul><li>0： 不自动续费</li><li>1： 自动续费</li></ul>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// <p>Memory 版本信息：v1。</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>Memory 当前已写入的记忆条数。</p>
        /// </summary>
        [JsonProperty("MemoryUsage")]
        public long? MemoryUsage{ get; set; }

        /// <summary>
        /// <p>Memory 实例记忆条数配额上限。</p>
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public long? MemoryLimit{ get; set; }

        /// <summary>
        /// <p>Memory 实例当前 Credit 的使用数量。</p>
        /// </summary>
        [JsonProperty("CreditUsage")]
        public float? CreditUsage{ get; set; }

        /// <summary>
        /// <p>Memory 实例 Credit 的最大使用数量。</p>
        /// </summary>
        [JsonProperty("CreditLimit")]
        public float? CreditLimit{ get; set; }

        /// <summary>
        /// <p>Memory 实例的内网访问地址。</p>
        /// </summary>
        [JsonProperty("AccessUrl")]
        public string AccessUrl{ get; set; }

        /// <summary>
        /// <p>Memory 实例的外网访问地址。</p>
        /// </summary>
        [JsonProperty("WanAccessUrl")]
        public string WanAccessUrl{ get; set; }

        /// <summary>
        /// <p>Memory 实例的创建时间。</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>Memory 实例的到期时间。</p>
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public string ExpiredAt{ get; set; }

        /// <summary>
        /// <p>Memory 实例的隔离时间。</p>
        /// </summary>
        [JsonProperty("IsolatedAt")]
        public string IsolatedAt{ get; set; }

        /// <summary>
        /// <p>到期销毁时间</p>
        /// </summary>
        [JsonProperty("DestroyAt")]
        public string DestroyAt{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "MemoryUsage", this.MemoryUsage);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "CreditUsage", this.CreditUsage);
            this.SetParamSimple(map, prefix + "CreditLimit", this.CreditLimit);
            this.SetParamSimple(map, prefix + "AccessUrl", this.AccessUrl);
            this.SetParamSimple(map, prefix + "WanAccessUrl", this.WanAccessUrl);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "IsolatedAt", this.IsolatedAt);
            this.SetParamSimple(map, prefix + "DestroyAt", this.DestroyAt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

