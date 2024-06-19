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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteDomainAndIpRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("Content")]
        public PublicIpDomainListKey[] Content{ get; set; }

        /// <summary>
        /// 是否保留路径配置，1：保留，其他：不保留，默认不传为不保留
        /// </summary>
        [JsonProperty("RetainPath")]
        public long? RetainPath{ get; set; }

        /// <summary>
        /// 以后是否忽略该资产，，1：忽略，其他：不忽略，默认不传为忽略
        /// </summary>
        [JsonProperty("IgnoreAsset")]
        public long? IgnoreAsset{ get; set; }

        /// <summary>
        /// 资产标签
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// 删除类型，取值： ALL， 删除全部，将直接忽略Content的内容；                                           其他值 ,非全部，则Centent必填，  默认为其他值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "RetainPath", this.RetainPath);
            this.SetParamSimple(map, prefix + "IgnoreAsset", this.IgnoreAsset);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

