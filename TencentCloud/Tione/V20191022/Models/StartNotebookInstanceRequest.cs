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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartNotebookInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Notebook实例名称
        /// </summary>
        [JsonProperty("NotebookInstanceName")]
        public string NotebookInstanceName{ get; set; }

        /// <summary>
        /// 自动停止，可取值Enabled/Disabled
        /// 取值为Disabled的时候StoppingCondition将被忽略
        /// 取值为Enabled的时候读取StoppingCondition作为自动停止的配置
        /// </summary>
        [JsonProperty("AutoStopping")]
        public string AutoStopping{ get; set; }

        /// <summary>
        /// 自动停止配置，只在AutoStopping为Enabled的时候生效
        /// </summary>
        [JsonProperty("StoppingCondition")]
        public StoppingCondition StoppingCondition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotebookInstanceName", this.NotebookInstanceName);
            this.SetParamSimple(map, prefix + "AutoStopping", this.AutoStopping);
            this.SetParamObj(map, prefix + "StoppingCondition.", this.StoppingCondition);
        }
    }
}

