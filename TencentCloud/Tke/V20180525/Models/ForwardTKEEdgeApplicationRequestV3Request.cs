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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ForwardTKEEdgeApplicationRequestV3Request : AbstractModel
    {
        
        /// <summary>
        /// 请求集群addon的访问
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 请求集群addon的路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 请求集群addon后允许接收的数据格式
        /// </summary>
        [JsonProperty("Accept")]
        public string Accept{ get; set; }

        /// <summary>
        /// 请求集群addon的数据格式
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 请求集群addon的数据
        /// </summary>
        [JsonProperty("RequestBody")]
        public string RequestBody{ get; set; }

        /// <summary>
        /// 集群名称，例如cls-1234abcd
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 是否编码请求内容
        /// </summary>
        [JsonProperty("EncodedBody")]
        public string EncodedBody{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Accept", this.Accept);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "RequestBody", this.RequestBody);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "EncodedBody", this.EncodedBody);
        }
    }
}

