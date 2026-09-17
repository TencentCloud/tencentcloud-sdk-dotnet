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

    public class PlatFormResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>资源类系</p><p>枚举值：</p><ul><li>log： 日志</li><li>storage： 云存储</li><li>hosting： 静态托管</li></ul>
        /// </summary>
        [JsonProperty("ResType")]
        public string ResType{ get; set; }

        /// <summary>
        /// <p>资源唯一标识</p>
        /// </summary>
        [JsonProperty("ResName")]
        public string ResName{ get; set; }

        /// <summary>
        /// <p>资源详细信息</p>
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// <p>资源状态</p><p>枚举值：</p><ul><li>0： 正常</li><li>5： 初始化中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>资源id</p>
        /// </summary>
        [JsonProperty("PlatformId")]
        public ulong? PlatformId{ get; set; }

        /// <summary>
        /// <p>对用平台资源id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResType", this.ResType);
            this.SetParamSimple(map, prefix + "ResName", this.ResName);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

