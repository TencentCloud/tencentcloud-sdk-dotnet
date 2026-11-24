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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MemberPermissionOption : AbstractModel
    {
        
        /// <summary>
        /// <p>权限 ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>权限名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>展示状态</p><p>枚举值：</p><ul><li>FIXED： 已勾选且置灰，不可修改</li><li>OPTIONAL： 正常可选</li><li>DISABLE： 置灰不可选，悬浮展示原因</li></ul><p>默认值：OPTIONAL</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否默认勾选</p>
        /// </summary>
        [JsonProperty("DefaultChecked")]
        public bool? DefaultChecked{ get; set; }

        /// <summary>
        /// <p>置灰原因码</p><p>枚举值：</p><ul><li>TransferNotAllowAdd： 资金划拨权限未命中白名单</li><li>CreditAmountsNotAllowAdd： 信用额度设置权限未命中白名单</li><li>AddDiscountInheritNotAllow： 校验不通过或异常</li></ul>
        /// </summary>
        [JsonProperty("DisabledCode")]
        public string DisabledCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DefaultChecked", this.DefaultChecked);
            this.SetParamSimple(map, prefix + "DisabledCode", this.DisabledCode);
        }
    }
}

