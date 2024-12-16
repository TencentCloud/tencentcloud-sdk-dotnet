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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRaspRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则ID(新增时请留空，编辑时候必传)
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 漏洞id数组
        /// </summary>
        [JsonProperty("VulVulsIDs")]
        public ulong?[] VulVulsIDs{ get; set; }

        /// <summary>
        /// 自定义请求范围加白正则表达式，选择全部请求范围时候为空，否则不能为空，base64编码
        /// </summary>
        [JsonProperty("URLRegexp")]
        public string URLRegexp{ get; set; }

        /// <summary>
        /// 加白方式，0：自定义请求范围加白。1：全部请求加白
        /// </summary>
        [JsonProperty("WhiteType")]
        public ulong? WhiteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "VulVulsIDs.", this.VulVulsIDs);
            this.SetParamSimple(map, prefix + "URLRegexp", this.URLRegexp);
            this.SetParamSimple(map, prefix + "WhiteType", this.WhiteType);
        }
    }
}

