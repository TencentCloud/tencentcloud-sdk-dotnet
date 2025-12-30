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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificateBindResourceTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>关联clb资源详情   </p>
        /// </summary>
        [JsonProperty("CLB")]
        public ClbInstanceList[] CLB{ get; set; }

        /// <summary>
        /// <p>关联cdn资源详情   </p>
        /// </summary>
        [JsonProperty("CDN")]
        public CdnInstanceList[] CDN{ get; set; }

        /// <summary>
        /// <p>关联waf资源详情   </p>
        /// </summary>
        [JsonProperty("WAF")]
        public WafInstanceList[] WAF{ get; set; }

        /// <summary>
        /// <p>关联ddos资源详情  </p>
        /// </summary>
        [JsonProperty("DDOS")]
        public DdosInstanceList[] DDOS{ get; set; }

        /// <summary>
        /// <p>关联live资源详情  </p>
        /// </summary>
        [JsonProperty("LIVE")]
        public LiveInstanceList[] LIVE{ get; set; }

        /// <summary>
        /// <p>关联vod资源详情   </p>
        /// </summary>
        [JsonProperty("VOD")]
        public VODInstanceList[] VOD{ get; set; }

        /// <summary>
        /// <p>关联tke资源详情   </p>
        /// </summary>
        [JsonProperty("TKE")]
        public TkeInstanceList[] TKE{ get; set; }

        /// <summary>
        /// <p>关联apigateway资源详情    </p>
        /// </summary>
        [JsonProperty("APIGATEWAY")]
        public ApiGatewayInstanceList[] APIGATEWAY{ get; set; }

        /// <summary>
        /// <p>关联tcb资源详情   </p>
        /// </summary>
        [JsonProperty("TCB")]
        public TCBInstanceList[] TCB{ get; set; }

        /// <summary>
        /// <p>关联teo资源详情   </p>
        /// </summary>
        [JsonProperty("TEO")]
        public TeoInstanceList[] TEO{ get; set; }

        /// <summary>
        /// <p>关联云资源异步查询结果： 0表示查询中， 1表示查询成功。 2表示查询异常； 若状态为1，则查看BindResourceResult结果；若状态为2，则查看Error原因</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>当前结果缓存时间</p>
        /// </summary>
        [JsonProperty("CacheTime")]
        public string CacheTime{ get; set; }

        /// <summary>
        /// <p>关联tse资源详情   </p>
        /// </summary>
        [JsonProperty("TSE")]
        public TSEInstanceList[] TSE{ get; set; }

        /// <summary>
        /// <p>关联的COS资源详情</p>
        /// </summary>
        [JsonProperty("COS")]
        public COSInstanceList[] COS{ get; set; }

        /// <summary>
        /// <p>关联的TDMQ - Rabbit资源详情</p>
        /// </summary>
        [JsonProperty("TDMQ")]
        public TDMQInstanceList[] TDMQ{ get; set; }

        /// <summary>
        /// <p>关联的MQTT资源详情</p>
        /// </summary>
        [JsonProperty("MQTT")]
        public MQTTInstanceList[] MQTT{ get; set; }

        /// <summary>
        /// <p>关联的GAAP资源详情</p>
        /// </summary>
        [JsonProperty("GAAP")]
        public GAAPInstanceList[] GAAP{ get; set; }

        /// <summary>
        /// <p>关联的SCF资源详情</p>
        /// </summary>
        [JsonProperty("SCF")]
        public SCFInstanceList[] SCF{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "CLB.", this.CLB);
            this.SetParamArrayObj(map, prefix + "CDN.", this.CDN);
            this.SetParamArrayObj(map, prefix + "WAF.", this.WAF);
            this.SetParamArrayObj(map, prefix + "DDOS.", this.DDOS);
            this.SetParamArrayObj(map, prefix + "LIVE.", this.LIVE);
            this.SetParamArrayObj(map, prefix + "VOD.", this.VOD);
            this.SetParamArrayObj(map, prefix + "TKE.", this.TKE);
            this.SetParamArrayObj(map, prefix + "APIGATEWAY.", this.APIGATEWAY);
            this.SetParamArrayObj(map, prefix + "TCB.", this.TCB);
            this.SetParamArrayObj(map, prefix + "TEO.", this.TEO);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
            this.SetParamArrayObj(map, prefix + "TSE.", this.TSE);
            this.SetParamArrayObj(map, prefix + "COS.", this.COS);
            this.SetParamArrayObj(map, prefix + "TDMQ.", this.TDMQ);
            this.SetParamArrayObj(map, prefix + "MQTT.", this.MQTT);
            this.SetParamArrayObj(map, prefix + "GAAP.", this.GAAP);
            this.SetParamArrayObj(map, prefix + "SCF.", this.SCF);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

