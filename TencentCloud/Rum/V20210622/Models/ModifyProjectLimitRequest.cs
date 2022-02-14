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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProjectLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// 项目接口
        /// </summary>
        [JsonProperty("ProjectInterface")]
        public string ProjectInterface{ get; set; }

        /// <summary>
        /// 上报比例   10代表10%
        /// </summary>
        [JsonProperty("ReportRate")]
        public long? ReportRate{ get; set; }

        /// <summary>
        /// 上报类型 1：比例  2：上报量
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "ProjectInterface", this.ProjectInterface);
            this.SetParamSimple(map, prefix + "ReportRate", this.ReportRate);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "ID", this.ID);
        }
    }
}

