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

    public class CreateCustomPackRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 生码数量, 普通码包时必填
        /// </summary>
        [JsonProperty("Amount")]
        public ulong? Amount{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }

        /// <summary>
        /// 码包类型 0: 普通码包 1: 层级码包
        /// </summary>
        [JsonProperty("PackType")]
        public ulong? PackType{ get; set; }

        /// <summary>
        /// 码包层级
        /// </summary>
        [JsonProperty("PackLevel")]
        public ulong? PackLevel{ get; set; }

        /// <summary>
        /// 层级码包规则
        /// </summary>
        [JsonProperty("PackSpec")]
        public PackSpec[] PackSpec{ get; set; }

        /// <summary>
        /// 码规则ID,  和CodeParts二选一必填
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// 码段配置，和CustomId二选一必填
        /// </summary>
        [JsonProperty("CodeParts")]
        public CodePart[] CodeParts{ get; set; }

        /// <summary>
        /// 批次ID，如果传了生码后会同时绑定批次，并激活码
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 是否有流水码 0:无 1:有
        /// </summary>
        [JsonProperty("SerialType")]
        public ulong? SerialType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "PackType", this.PackType);
            this.SetParamSimple(map, prefix + "PackLevel", this.PackLevel);
            this.SetParamArrayObj(map, prefix + "PackSpec.", this.PackSpec);
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamArrayObj(map, prefix + "CodeParts.", this.CodeParts);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "SerialType", this.SerialType);
        }
    }
}

