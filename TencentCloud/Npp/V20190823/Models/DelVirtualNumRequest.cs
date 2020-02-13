/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Npp.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DelVirtualNumRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务appid
        /// </summary>
        [JsonProperty("BizAppId")]
        public string BizAppId{ get; set; }

        /// <summary>
        /// 双方号码 + 中间号绑定 ID，该 ID 全局唯一
        /// </summary>
        [JsonProperty("BindId")]
        public string BindId{ get; set; }

        /// <summary>
        /// 应用二级业务 ID，bizId 需保证在该 appId 下全局唯一，最大长度不超过 16 个字节。
        /// </summary>
        [JsonProperty("BizId")]
        public string BizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizAppId", this.BizAppId);
            this.SetParamSimple(map, prefix + "BindId", this.BindId);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
        }
    }
}

