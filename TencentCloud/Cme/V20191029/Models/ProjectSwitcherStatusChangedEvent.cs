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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProjectSwitcherStatusChangedEvent : AbstractModel
    {
        
        /// <summary>
        /// 导播台项目 Id。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 导播台项目状态，可取值有：
        /// <li>Started：导播台启动；</li>
        /// <li>Stopped：导播台停止；</li>
        /// <li>PvwStarted：导播台 PVW 开启；</li>
        /// <li>PgmStarted：导播台 PGM 开启，输出推流开始；</li>
        /// <li>PvwStopped：导播台 PVW 停止；</li>
        /// <li>PgmStopped：导播台 PGM 停止，输出推流结束。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

