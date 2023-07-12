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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongUpstreamInfo : AbstractModel
    {
        
        /// <summary>
        /// IP或域名
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 服务来源ID
        /// </summary>
        [JsonProperty("SourceID")]
        public string SourceID{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 服务（注册中心或Kubernetes中的服务）名字
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 服务后端类型是IPList时提供
        /// </summary>
        [JsonProperty("Targets")]
        public KongTarget[] Targets{ get; set; }

        /// <summary>
        /// 服务来源类型
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// SCF函数类型
        /// </summary>
        [JsonProperty("ScfType")]
        public string ScfType{ get; set; }

        /// <summary>
        /// SCF函数命名空间
        /// </summary>
        [JsonProperty("ScfNamespace")]
        public string ScfNamespace{ get; set; }

        /// <summary>
        /// SCF函数名
        /// </summary>
        [JsonProperty("ScfLambdaName")]
        public string ScfLambdaName{ get; set; }

        /// <summary>
        /// SCF函数版本
        /// </summary>
        [JsonProperty("ScfLambdaQualifier")]
        public string ScfLambdaQualifier{ get; set; }

        /// <summary>
        /// 冷启动时间，单位秒
        /// </summary>
        [JsonProperty("SlowStart")]
        public long? SlowStart{ get; set; }

        /// <summary>
        /// 负载均衡算法，默认为 round-robin，还支持 least-connections，consisten_hashing
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// CVM弹性伸缩组ID
        /// </summary>
        [JsonProperty("AutoScalingGroupID")]
        public string AutoScalingGroupID{ get; set; }

        /// <summary>
        /// CVM弹性伸缩组端口
        /// </summary>
        [JsonProperty("AutoScalingCvmPort")]
        public ulong? AutoScalingCvmPort{ get; set; }

        /// <summary>
        /// CVM弹性伸缩组使用的CVM TAT命令状态
        /// </summary>
        [JsonProperty("AutoScalingTatCmdStatus")]
        public string AutoScalingTatCmdStatus{ get; set; }

        /// <summary>
        /// CVM弹性伸缩组生命周期挂钩状态
        /// </summary>
        [JsonProperty("AutoScalingHookStatus")]
        public string AutoScalingHookStatus{ get; set; }

        /// <summary>
        /// 服务来源的名字
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 精确的服务来源类型，新建服务来源时候传入的类型
        /// </summary>
        [JsonProperty("RealSourceType")]
        public string RealSourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "SourceID", this.SourceID);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ScfType", this.ScfType);
            this.SetParamSimple(map, prefix + "ScfNamespace", this.ScfNamespace);
            this.SetParamSimple(map, prefix + "ScfLambdaName", this.ScfLambdaName);
            this.SetParamSimple(map, prefix + "ScfLambdaQualifier", this.ScfLambdaQualifier);
            this.SetParamSimple(map, prefix + "SlowStart", this.SlowStart);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "AutoScalingGroupID", this.AutoScalingGroupID);
            this.SetParamSimple(map, prefix + "AutoScalingCvmPort", this.AutoScalingCvmPort);
            this.SetParamSimple(map, prefix + "AutoScalingTatCmdStatus", this.AutoScalingTatCmdStatus);
            this.SetParamSimple(map, prefix + "AutoScalingHookStatus", this.AutoScalingHookStatus);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "RealSourceType", this.RealSourceType);
        }
    }
}

