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

    public class CreateTimerReportRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务名称 不变更为&quot;&quot;</p>
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// <p>执行日期 重复周期为天：无意义周：星期几1-7月每月几号 1-31</p>
        /// </summary>
        [JsonProperty("CntTime")]
        public long? CntTime{ get; set; }

        /// <summary>
        /// <p>重复周期</p>
        /// </summary>
        [JsonProperty("CntCycle")]
        public long? CntCycle{ get; set; }

        /// <summary>
        /// <p>发送目标</p>
        /// </summary>
        [JsonProperty("Receivers")]
        public string Receivers{ get; set; }

        /// <summary>
        /// <p>时间范围 1:24小时 7:近一周 30:近30天 90:近90天 180:近180天 不变更为0</p>
        /// </summary>
        [JsonProperty("CntDay")]
        public long? CntDay{ get; set; }

        /// <summary>
        /// <p>执行时间 格式15:04 到分钟</p>
        /// </summary>
        [JsonProperty("CntDate")]
        public string CntDate{ get; set; }

        /// <summary>
        /// <p>报告说明</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>模板Id</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// <p>报表类型</p>
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// <p>关联的资产数组</p>
        /// </summary>
        [JsonProperty("AssetsId")]
        public long?[] AssetsId{ get; set; }

        /// <summary>
        /// <p>报表通知 1关闭 2开启 不变更为0</p>
        /// </summary>
        [JsonProperty("Notification")]
        public long? Notification{ get; set; }

        /// <summary>
        /// <p>任务起停 1:关闭 2:开启 单次报表默认为2</p>
        /// </summary>
        [JsonProperty("MissionStart")]
        public long? MissionStart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "CntTime", this.CntTime);
            this.SetParamSimple(map, prefix + "CntCycle", this.CntCycle);
            this.SetParamSimple(map, prefix + "Receivers", this.Receivers);
            this.SetParamSimple(map, prefix + "CntDay", this.CntDay);
            this.SetParamSimple(map, prefix + "CntDate", this.CntDate);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamArraySimple(map, prefix + "AssetsId.", this.AssetsId);
            this.SetParamSimple(map, prefix + "Notification", this.Notification);
            this.SetParamSimple(map, prefix + "MissionStart", this.MissionStart);
        }
    }
}

