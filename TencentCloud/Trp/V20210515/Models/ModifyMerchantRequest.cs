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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMerchantRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 商户标识码
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 码包来源 0:自建, 1:第三方码包，暂不支持修改
        /// </summary>
        [JsonProperty("CodeType")]
        public long? CodeType{ get; set; }

        /// <summary>
        /// 码包前缀地址 第三方码包时必填
        /// </summary>
        [JsonProperty("CodeUrl")]
        public string CodeUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
            this.SetParamSimple(map, prefix + "CodeUrl", this.CodeUrl);
        }
    }
}

