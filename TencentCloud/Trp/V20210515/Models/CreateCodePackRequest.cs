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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCodePackRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 码长度
        /// </summary>
        [JsonProperty("CodeLength")]
        public ulong? CodeLength{ get; set; }

        /// <summary>
        /// 码类型 alphabet 字母, number 数字, mixin 混合
        /// </summary>
        [JsonProperty("CodeType")]
        public string CodeType{ get; set; }

        /// <summary>
        /// 生码数量 普通码包时必填
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

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
        /// 码包规格
        /// </summary>
        [JsonProperty("PackSpec")]
        public PackSpec[] PackSpec{ get; set; }

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
        /// 关联产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 层级码时是否提前生成关联关系，默认为 1
        /// </summary>
        [JsonProperty("RelateType")]
        public long? RelateType{ get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [JsonProperty("SceneCode")]
        public long? SceneCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "CodeLength", this.CodeLength);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "PackType", this.PackType);
            this.SetParamSimple(map, prefix + "PackLevel", this.PackLevel);
            this.SetParamArrayObj(map, prefix + "PackSpec.", this.PackSpec);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "SerialType", this.SerialType);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "RelateType", this.RelateType);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
        }
    }
}

