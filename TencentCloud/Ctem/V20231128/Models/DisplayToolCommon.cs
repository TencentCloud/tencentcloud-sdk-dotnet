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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayToolCommon : AbstractModel
    {
        
        /// <summary>
        /// 子公司ID
        /// </summary>
        [JsonProperty("EnterpriseUid")]
        public string EnterpriseUid{ get; set; }

        /// <summary>
        /// 子公司名称
        /// </summary>
        [JsonProperty("EnterpriseName")]
        public string EnterpriseName{ get; set; }

        /// <summary>
        /// 主任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 单任务ID
        /// </summary>
        [JsonProperty("JobStageId")]
        public long? JobStageId{ get; set; }

        /// <summary>
        /// 是否忽略
        /// </summary>
        [JsonProperty("Ignored")]
        public bool? Ignored{ get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("JobRecordId")]
        public long? JobRecordId{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// Md5值
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }

        /// <summary>
        /// 标签列表，json格式：{\"tag1\":[\"责任人xxx\"],\"tag2\":[\"测试站\"]}
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnterpriseUid", this.EnterpriseUid);
            this.SetParamSimple(map, prefix + "EnterpriseName", this.EnterpriseName);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobStageId", this.JobStageId);
            this.SetParamSimple(map, prefix + "Ignored", this.Ignored);
            this.SetParamSimple(map, prefix + "JobRecordId", this.JobRecordId);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
            this.SetParamSimple(map, prefix + "Labels", this.Labels);
        }
    }
}

