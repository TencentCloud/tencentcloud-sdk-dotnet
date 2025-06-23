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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployRecord : AbstractModel
    {
        
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 成功总数
        /// </summary>
        [JsonProperty("SuccessTotalCount")]
        public long? SuccessTotalCount{ get; set; }

        /// <summary>
        /// 失败总数
        /// </summary>
        [JsonProperty("FailedTotalCount")]
        public long? FailedTotalCount{ get; set; }

        /// <summary>
        /// 部署中总数
        /// </summary>
        [JsonProperty("RunningTotalCount")]
        public long? RunningTotalCount{ get; set; }

        /// <summary>
        /// 部署记录类型 0 为部署， 1 为回滚
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 部署记录详情列表
        /// </summary>
        [JsonProperty("RecordDetailList")]
        public DeployRecordList[] RecordDetailList{ get; set; }

        /// <summary>
        /// 托管资源部署状态：0 等待部署， 1 部署成功， 2 部署失败 3 部署中， 4 回滚成功， 5 回滚失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 托管资源创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "SuccessTotalCount", this.SuccessTotalCount);
            this.SetParamSimple(map, prefix + "FailedTotalCount", this.FailedTotalCount);
            this.SetParamSimple(map, prefix + "RunningTotalCount", this.RunningTotalCount);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "RecordDetailList.", this.RecordDetailList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

