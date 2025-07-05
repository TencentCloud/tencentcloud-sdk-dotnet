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

    public class CodeBatch : AbstractModel
    {
        
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public long? CorpId{ get; set; }

        /// <summary>
        /// 批次编码(未使用)
        /// </summary>
        [JsonProperty("BatchCode")]
        public string BatchCode{ get; set; }

        /// <summary>
        /// 码数量
        /// </summary>
        [JsonProperty("CodeCnt")]
        public long? CodeCnt{ get; set; }

        /// <summary>
        /// 所属商户ID
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 批次类型
        /// </summary>
        [JsonProperty("BatchType")]
        public long? BatchType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 微信模板
        /// </summary>
        [JsonProperty("MpTpl")]
        public string MpTpl{ get; set; }

        /// <summary>
        /// 批次状态 0: 未激活 1: 已激活 -1: 已冻结
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 所属商户名称
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 未使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ext")]
        [System.Obsolete]
        public Ext Ext{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// 调度任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Job")]
        public Job Job{ get; set; }

        /// <summary>
        /// 生产日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductionDate")]
        public string ProductionDate{ get; set; }

        /// <summary>
        /// 有效期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [JsonProperty("Attrs")]
        public AttrItem[] Attrs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
            this.SetParamSimple(map, prefix + "BatchCode", this.BatchCode);
            this.SetParamSimple(map, prefix + "CodeCnt", this.CodeCnt);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "BatchType", this.BatchType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MpTpl", this.MpTpl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamObj(map, prefix + "Ext.", this.Ext);
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamObj(map, prefix + "Job.", this.Job);
            this.SetParamSimple(map, prefix + "ProductionDate", this.ProductionDate);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamArrayObj(map, prefix + "Attrs.", this.Attrs);
        }
    }
}

