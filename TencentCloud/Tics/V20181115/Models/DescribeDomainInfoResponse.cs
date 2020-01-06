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

namespace TencentCloud.Tics.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否有数据，0代表有数据，1代表没有数据
        /// </summary>
        [JsonProperty("ReturnCode")]
        public ulong? ReturnCode{ get; set; }

        /// <summary>
        /// 判定结果，如：black、white、grey
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 置信度，取值0-100
        /// </summary>
        [JsonProperty("Confidence")]
        public ulong? Confidence{ get; set; }

        /// <summary>
        /// 威胁类型。
        /// botnet = 僵尸网络
        /// trojan = 木马
        /// ransomware = 勒索软件
        /// worm = 蠕虫
        /// dga = 域名生成算法
        /// c2 = c&c
        /// compromised = 失陷主机
        /// dynamicIP = 动态IP
        /// proxy = 代理
        /// idc = idc 机房
        /// whitelist = 白名单
        /// tor = 暗网
        /// miner = 挖矿
        /// maleware site = 恶意站点
        /// malware IP = 恶意IP
        /// 等等
        /// </summary>
        [JsonProperty("ThreatTypes")]
        public string[] ThreatTypes{ get; set; }

        /// <summary>
        /// 恶意标签，对应的团伙，家族等信息。
        /// </summary>
        [JsonProperty("Tags")]
        public TagType[] Tags{ get; set; }

        /// <summary>
        /// 对应的历史上的威胁情报事件
        /// </summary>
        [JsonProperty("Intelligences")]
        public IntelligenceType[] Intelligences{ get; set; }

        /// <summary>
        /// 情报相关的上下文
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArraySimple(map, prefix + "ThreatTypes.", this.ThreatTypes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Intelligences.", this.Intelligences);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

