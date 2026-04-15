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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateRecordBackupTemplateData : AbstractModel
    {
        
        /// <summary>
        /// <p>模板ID</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>模板名称</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>上云时间段（按周进行设置，支持一天设置多个时间段，每个时间段不小于10分钟）</p>
        /// </summary>
        [JsonProperty("TimeSections")]
        public RecordTemplateTimeSections[] TimeSections{ get; set; }

        /// <summary>
        /// <p>录像时间段（按周进行设置，支持一天设置多个时间段，每个时间段不小于10分钟）</p>
        /// </summary>
        [JsonProperty("DevTimeSections")]
        public RecordTemplateTimeSections[] DevTimeSections{ get; set; }

        /// <summary>
        /// <p>上云倍速（支持1，2，4倍速）</p>
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

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
        /// <p>周期偏移量，默认1，表示拉取昨天的设备录像，0表示取去今天的设备录像，3表示拉取前天的设备录像</p>
        /// </summary>
        [JsonProperty("DayOffset")]
        public long? DayOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamArrayObj(map, prefix + "TimeSections.", this.TimeSections);
            this.SetParamArrayObj(map, prefix + "DevTimeSections.", this.DevTimeSections);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
            this.SetParamSimple(map, prefix + "DayOffset", this.DayOffset);
        }
    }
}

