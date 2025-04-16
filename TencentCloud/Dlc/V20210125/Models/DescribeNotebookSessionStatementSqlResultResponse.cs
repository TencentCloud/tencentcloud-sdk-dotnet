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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNotebookSessionStatementSqlResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 结果数据
        /// </summary>
        [JsonProperty("ResultSet")]
        public string ResultSet{ get; set; }

        /// <summary>
        /// schema
        /// </summary>
        [JsonProperty("ResultSchema")]
        public Column[] ResultSchema{ get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 存储结果地址
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// 引擎计算耗时
        /// </summary>
        [JsonProperty("UseTime")]
        public long? UseTime{ get; set; }

        /// <summary>
        /// 结果条数
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// 数据扫描量
        /// </summary>
        [JsonProperty("DataAmount")]
        public long? DataAmount{ get; set; }

        /// <summary>
        /// spark ui地址
        /// </summary>
        [JsonProperty("UiUrl")]
        public string UiUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ResultSet", this.ResultSet);
            this.SetParamArrayObj(map, prefix + "ResultSchema.", this.ResultSchema);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "UseTime", this.UseTime);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "DataAmount", this.DataAmount);
            this.SetParamSimple(map, prefix + "UiUrl", this.UiUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

