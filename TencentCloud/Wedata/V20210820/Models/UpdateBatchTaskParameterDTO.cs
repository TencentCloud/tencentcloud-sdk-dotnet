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

    public class UpdateBatchTaskParameterDTO : AbstractModel
    {
        
        /// <summary>
        /// spark作业driver资源规格大小, 可取small,medium,large,xlarge
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// 指定的Executor数量（最大值），默认为1，当开启动态分配有效，若未开启，则该值等于AppExecutorNums
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public string ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// spark作业executor个数
        /// </summary>
        [JsonProperty("ExecutorNumbers")]
        public string ExecutorNumbers{ get; set; }

        /// <summary>
        /// spark作业executor资源规格大小, 可取small,medium,large,xlarge
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// sparksql和presto引擎参数
        /// </summary>
        [JsonProperty("RunConfParams")]
        public string RunConfParams{ get; set; }

        /// <summary>
        /// 任务资源配置是否继承集群模板，0（默认）不继承，1：继承
        /// </summary>
        [JsonProperty("IsInherit")]
        public string IsInherit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "ExecutorNumbers", this.ExecutorNumbers);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "RunConfParams", this.RunConfParams);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
        }
    }
}

