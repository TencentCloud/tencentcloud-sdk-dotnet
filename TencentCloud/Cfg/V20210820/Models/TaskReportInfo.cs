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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskReportInfo : AbstractModel
    {
        
        /// <summary>
        /// 0--未开始，1--正在导出，2--导出成功，3--导出失败
        /// </summary>
        [JsonProperty("Stage")]
        public long? Stage{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 有效期截止时间
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public string ExpirationTime{ get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        [JsonProperty("Expired")]
        public bool? Expired{ get; set; }

        /// <summary>
        /// 演练报告cos文件地址
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// 演练报告导出日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 0--未开始，1--正在归档，2--归档成功，3--归档失败
        /// </summary>
        [JsonProperty("ArchiveStage")]
        public long? ArchiveStage{ get; set; }

        /// <summary>
        /// 归档时间
        /// </summary>
        [JsonProperty("ArchiveTime")]
        public string ArchiveTime{ get; set; }

        /// <summary>
        /// 归档ID
        /// </summary>
        [JsonProperty("ArchiveUuid")]
        public string ArchiveUuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpirationTime", this.ExpirationTime);
            this.SetParamSimple(map, prefix + "Expired", this.Expired);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "ArchiveStage", this.ArchiveStage);
            this.SetParamSimple(map, prefix + "ArchiveTime", this.ArchiveTime);
            this.SetParamSimple(map, prefix + "ArchiveUuid", this.ArchiveUuid);
        }
    }
}

