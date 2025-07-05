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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEdgeCVMInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id，边缘集群需要先开启公网访问才能添加cvm节点
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// CVM创建透传参数，json化字符串格式，如需要保证扩展集群节点请求幂等性需要在此参数添加ClientToken字段，详见[CVM创建实例](https://cloud.tencent.com/document/product/213/15730)接口。
        /// </summary>
        [JsonProperty("RunInstancePara")]
        public string RunInstancePara{ get; set; }

        /// <summary>
        /// CVM所属Region
        /// </summary>
        [JsonProperty("CvmRegion")]
        public string CvmRegion{ get; set; }

        /// <summary>
        /// CVM数量
        /// </summary>
        [JsonProperty("CvmCount")]
        public long? CvmCount{ get; set; }

        /// <summary>
        /// 实例扩展信息
        /// </summary>
        [JsonProperty("External")]
        public string External{ get; set; }

        /// <summary>
        /// 用户自定义脚本
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// 是否开启弹性网卡功能
        /// </summary>
        [JsonProperty("EnableEni")]
        public bool? EnableEni{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "RunInstancePara", this.RunInstancePara);
            this.SetParamSimple(map, prefix + "CvmRegion", this.CvmRegion);
            this.SetParamSimple(map, prefix + "CvmCount", this.CvmCount);
            this.SetParamSimple(map, prefix + "External", this.External);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamSimple(map, prefix + "EnableEni", this.EnableEni);
        }
    }
}

