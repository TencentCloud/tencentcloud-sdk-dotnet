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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAttackLogInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 攻击来源端口
        /// </summary>
        [JsonProperty("SrcPort")]
        public ulong? SrcPort{ get; set; }

        /// <summary>
        /// 攻击来源IP
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 攻击目标端口
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// 攻击目标IP
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 攻击方法
        /// </summary>
        [JsonProperty("HttpMethod")]
        public string HttpMethod{ get; set; }

        /// <summary>
        /// 攻击目标主机
        /// </summary>
        [JsonProperty("HttpHost")]
        public string HttpHost{ get; set; }

        /// <summary>
        /// 攻击头信息
        /// </summary>
        [JsonProperty("HttpHead")]
        public string HttpHead{ get; set; }

        /// <summary>
        /// 攻击者浏览器标识
        /// </summary>
        [JsonProperty("HttpUserAgent")]
        public string HttpUserAgent{ get; set; }

        /// <summary>
        /// 请求源
        /// </summary>
        [JsonProperty("HttpReferer")]
        public string HttpReferer{ get; set; }

        /// <summary>
        /// 威胁类型
        /// </summary>
        [JsonProperty("VulType")]
        public string VulType{ get; set; }

        /// <summary>
        /// 攻击路径
        /// </summary>
        [JsonProperty("HttpCgi")]
        public string HttpCgi{ get; set; }

        /// <summary>
        /// 攻击参数
        /// </summary>
        [JsonProperty("HttpParam")]
        public string HttpParam{ get; set; }

        /// <summary>
        /// 攻击时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 攻击内容
        /// </summary>
        [JsonProperty("HttpContent")]
        public string HttpContent{ get; set; }

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
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "SrcPort", this.SrcPort);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "HttpMethod", this.HttpMethod);
            this.SetParamSimple(map, prefix + "HttpHost", this.HttpHost);
            this.SetParamSimple(map, prefix + "HttpHead", this.HttpHead);
            this.SetParamSimple(map, prefix + "HttpUserAgent", this.HttpUserAgent);
            this.SetParamSimple(map, prefix + "HttpReferer", this.HttpReferer);
            this.SetParamSimple(map, prefix + "VulType", this.VulType);
            this.SetParamSimple(map, prefix + "HttpCgi", this.HttpCgi);
            this.SetParamSimple(map, prefix + "HttpParam", this.HttpParam);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "HttpContent", this.HttpContent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

