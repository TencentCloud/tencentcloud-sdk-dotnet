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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Monitor : AbstractModel
    {
        
        /// <summary>
        /// 作品ID
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// 作品名称
        /// </summary>
        [JsonProperty("WorkName")]
        public string WorkName{ get; set; }

        /// <summary>
        /// 作品内容类型 01-视频 02-音频 03-文本 04-图片
        /// </summary>
        [JsonProperty("WorkType")]
        public string WorkType{ get; set; }

        /// <summary>
        /// 侵权平台数量
        /// </summary>
        [JsonProperty("TortPlatNum")]
        public long? TortPlatNum{ get; set; }

        /// <summary>
        /// 侵权链接数量
        /// </summary>
        [JsonProperty("TortURLNum")]
        public long? TortURLNum{ get; set; }

        /// <summary>
        /// 监测时间
        /// </summary>
        [JsonProperty("MonitorTime")]
        public string MonitorTime{ get; set; }

        /// <summary>
        /// 0-待监测 1-监测中 2-不监测 3-暂停监测
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public long? MonitorStatus{ get; set; }

        /// <summary>
        /// 作品类型
        /// </summary>
        [JsonProperty("WorkCategory")]
        public string WorkCategory{ get; set; }

        /// <summary>
        /// 新增时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 监测状态说明
        /// </summary>
        [JsonProperty("MonitorNote")]
        public string MonitorNote{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "WorkName", this.WorkName);
            this.SetParamSimple(map, prefix + "WorkType", this.WorkType);
            this.SetParamSimple(map, prefix + "TortPlatNum", this.TortPlatNum);
            this.SetParamSimple(map, prefix + "TortURLNum", this.TortURLNum);
            this.SetParamSimple(map, prefix + "MonitorTime", this.MonitorTime);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "WorkCategory", this.WorkCategory);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "MonitorNote", this.MonitorNote);
        }
    }
}

