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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDorisMetricFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 接口类型
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 展示监控指标入参
        /// </summary>
        [JsonProperty("DescribeMetricsFileReq")]
        public DescribeMetricsFileReq DescribeMetricsFileReq{ get; set; }

        /// <summary>
        /// 点关注功能入参
        /// </summary>
        [JsonProperty("ModifyMetricFileReq")]
        public ModifyMetricFileStruct ModifyMetricFileReq{ get; set; }

        /// <summary>
        /// 监控指标关注功能入参
        /// </summary>
        [JsonProperty("ModifyAttentionMetricFileReq")]
        public ModifyMetricFileStructNew ModifyAttentionMetricFileReq{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "DescribeMetricsFileReq.", this.DescribeMetricsFileReq);
            this.SetParamObj(map, prefix + "ModifyMetricFileReq.", this.ModifyMetricFileReq);
            this.SetParamObj(map, prefix + "ModifyAttentionMetricFileReq.", this.ModifyAttentionMetricFileReq);
        }
    }
}

