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

    public class DescribeCertificateBindResourceTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 关联clb资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLB")]
        public ClbInstanceList[] CLB{ get; set; }

        /// <summary>
        /// 关联cdn资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CDN")]
        public CdnInstanceList[] CDN{ get; set; }

        /// <summary>
        /// 关联waf资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WAF")]
        public WafInstanceList[] WAF{ get; set; }

        /// <summary>
        /// 关联ddos资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDOS")]
        public DdosInstanceList[] DDOS{ get; set; }

        /// <summary>
        /// 关联live资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LIVE")]
        public LiveInstanceList[] LIVE{ get; set; }

        /// <summary>
        /// 关联vod资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VOD")]
        public VODInstanceList[] VOD{ get; set; }

        /// <summary>
        /// 关联tke资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TKE")]
        public TkeInstanceList[] TKE{ get; set; }

        /// <summary>
        /// 关联apigateway资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("APIGATEWAY")]
        public ApiGatewayInstanceList[] APIGATEWAY{ get; set; }

        /// <summary>
        /// 关联tcb资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TCB")]
        public TCBInstanceList[] TCB{ get; set; }

        /// <summary>
        /// 关联teo资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TEO")]
        public TeoInstanceList[] TEO{ get; set; }

        /// <summary>
        /// 关联云资源异步查询结果： 0表示查询中， 1表示查询成功。 2表示查询异常； 若状态为1，则查看BindResourceResult结果；若状态为2，则查看Error原因
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 当前结果缓存时间
        /// </summary>
        [JsonProperty("CacheTime")]
        public string CacheTime{ get; set; }

        /// <summary>
        /// 关联tse资源详情	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TSE")]
        public TSEInstanceList[] TSE{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

