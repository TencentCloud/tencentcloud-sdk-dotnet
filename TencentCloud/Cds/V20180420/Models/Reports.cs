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

namespace TencentCloud.Cds.V20180420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Reports : AbstractModel
    {
        
        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("AddTime")]
        public long? AddTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 报告 ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 审计 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        [JsonProperty("IsDelete")]
        public long? IsDelete{ get; set; }

        /// <summary>
        /// 发送目标
        /// </summary>
        [JsonProperty("Receivers")]
        public string Receivers{ get; set; }

        /// <summary>
        /// 报告说明
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 报告文件
        /// </summary>
        [JsonProperty("ReportFile")]
        public string ReportFile{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("ReportStatus")]
        public long? ReportStatus{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("ReportTmpStatus")]
        public long? ReportTmpStatus{ get; set; }

        /// <summary>
        /// 报告类型
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// 发送结果
        /// </summary>
        [JsonProperty("SendResult")]
        public string SendResult{ get; set; }

        /// <summary>
        /// 发送类型
        /// </summary>
        [JsonProperty("SendType")]
        public string SendType{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 报表模板
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 包含资产
        /// </summary>
        [JsonProperty("AssetsList")]
        public AssetsInfo[] AssetsList{ get; set; }

        /// <summary>
        /// 时间范围 1:24小时 7:近一周 30:近30天 90:近90天 180:近180天 不变更为0
        /// </summary>
        [JsonProperty("CntDay")]
        public long? CntDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
            this.SetParamSimple(map, prefix + "Receivers", this.Receivers);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReportFile", this.ReportFile);
            this.SetParamSimple(map, prefix + "ReportStatus", this.ReportStatus);
            this.SetParamSimple(map, prefix + "ReportTmpStatus", this.ReportTmpStatus);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "SendResult", this.SendResult);
            this.SetParamSimple(map, prefix + "SendType", this.SendType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArrayObj(map, prefix + "AssetsList.", this.AssetsList);
            this.SetParamSimple(map, prefix + "CntDay", this.CntDay);
        }
    }
}

