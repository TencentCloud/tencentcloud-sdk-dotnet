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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NFOption : AbstractModel
    {
        
        /// <summary>
        /// Config。
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// Profile。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// Report。
        /// </summary>
        [JsonProperty("Report")]
        public bool? Report{ get; set; }

        /// <summary>
        /// Resume。
        /// </summary>
        [JsonProperty("Resume")]
        public bool? Resume{ get; set; }

        /// <summary>
        /// Nextflow引擎版本，取值范围：
        /// - 22.10.7
        /// - 23.10.1
        /// </summary>
        [JsonProperty("NFVersion")]
        public string NFVersion{ get; set; }

        /// <summary>
        /// 启动路径。可填写指定缓存卷内的绝对路径，nextflow run 命令将在此路径执行。当WorkDir为COS路径时必填；当WorkDir为缓存卷路径时选填，不填默认使用WorkDir作为LaunchDir。
        /// </summary>
        [JsonProperty("LaunchDir")]
        public string LaunchDir{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "Report", this.Report);
            this.SetParamSimple(map, prefix + "Resume", this.Resume);
            this.SetParamSimple(map, prefix + "NFVersion", this.NFVersion);
            this.SetParamSimple(map, prefix + "LaunchDir", this.LaunchDir);
        }
    }
}

