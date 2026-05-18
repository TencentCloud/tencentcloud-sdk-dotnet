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
        /// <p>子公司ID</p>
        /// </summary>
        [JsonProperty("EnterpriseUid")]
        public string EnterpriseUid{ get; set; }

        /// <summary>
        /// <p>子公司名称</p>
        /// </summary>
        [JsonProperty("EnterpriseName")]
        public string EnterpriseName{ get; set; }

        /// <summary>
        /// <p>主任务ID</p>
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// <p>单任务ID</p>
        /// </summary>
        [JsonProperty("JobStageId")]
        public long? JobStageId{ get; set; }

        /// <summary>
        /// <p>是否忽略</p>
        /// </summary>
        [JsonProperty("Ignored")]
        public bool? Ignored{ get; set; }

        /// <summary>
        /// <p>子任务ID</p>
        /// </summary>
        [JsonProperty("JobRecordId")]
        public long? JobRecordId{ get; set; }

        /// <summary>
        /// <p>企业ID</p>
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// <p>企业名称</p>
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// <p>详情</p>
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// <p>Md5值</p>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }

        /// <summary>
        /// <p>标签列表，json格式：{"tag1":["责任人xxx"],"tag2":["测试站"]}</p>
        /// </summary>
        [JsonProperty("Labels")]
        public string Labels{ get; set; }

        /// <summary>
        /// <p>演示模式是否明文展示</p><p>枚举值：</p><ul><li>0： 否</li><li>1： 是</li></ul>
        /// </summary>
        [JsonProperty("IsPlainTextInDemo")]
        public long? IsPlainTextInDemo{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsPlainTextInDemo", this.IsPlainTextInDemo);
        }
    }
}

