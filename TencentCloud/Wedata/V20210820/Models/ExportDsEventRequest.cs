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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportDsEventRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// cos地址
        /// </summary>
        [JsonProperty("OriginDomain")]
        public string OriginDomain{ get; set; }

        /// <summary>
        /// 事件范围 ALL、PUBLISH、PARTIAL
        /// </summary>
        [JsonProperty("Range")]
        public string Range{ get; set; }

        /// <summary>
        /// 事件名称列表,用于发布管理导出
        /// </summary>
        [JsonProperty("EventNames")]
        public string[] EventNames{ get; set; }

        /// <summary>
        /// 事件列表
        /// </summary>
        [JsonProperty("Events")]
        public EventDsDto[] Events{ get; set; }

        /// <summary>
        /// 增量发布事件
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 文件标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "OriginDomain", this.OriginDomain);
            this.SetParamSimple(map, prefix + "Range", this.Range);
            this.SetParamArraySimple(map, prefix + "EventNames.", this.EventNames);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "Title", this.Title);
        }
    }
}

