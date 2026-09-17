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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlatformInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>平台版套餐id</p>
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// <p>套餐别名</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>套餐id</p>
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// <p>计费状态</p><p>枚举值：</p><ul><li>normal： 正常</li><li>isolated： 已隔离</li><li>destroyed： 已销毁</li></ul>
        /// </summary>
        [JsonProperty("BillStatus")]
        public string BillStatus{ get; set; }

        /// <summary>
        /// <p>套餐资源状态</p><p>枚举值：</p><ul><li>0： 可用</li><li>5： 发货中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>资源配置</p>
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>购买时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("BillTime")]
        public string BillTime{ get; set; }

        /// <summary>
        /// <p>套餐过期时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>是否自动续费</p><p>枚举值：</p><ul><li>0： 未设置</li><li>1： 自动续费</li><li>2： 设置为到期不续费</li></ul>
        /// </summary>
        [JsonProperty("IsAutoRenew")]
        public ulong? IsAutoRenew{ get; set; }

        /// <summary>
        /// <p>资源信息列表</p>
        /// </summary>
        [JsonProperty("Resources")]
        public PlatFormResourceInfo[] Resources{ get; set; }

        /// <summary>
        /// <p>所属地域</p><p>枚举值：</p><ul><li>ap-shanghai： 上海</li><li>ap-singapore： 新加坡</li></ul>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "BillStatus", this.BillStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "BillTime", this.BillTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsAutoRenew", this.IsAutoRenew);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

