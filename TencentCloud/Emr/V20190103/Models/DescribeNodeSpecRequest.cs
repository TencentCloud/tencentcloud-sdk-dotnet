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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNodeSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区Id，可以通过https://document.capi.woa.com/document/api/1605/76892查询相关信息
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 0,按量，1包年包月，99按量+包年包月，错填将不会展示费用信息
        /// </summary>
        [JsonProperty("CvmPayMode")]
        public ulong? CvmPayMode{ get; set; }

        /// <summary>
        /// 节点类型,Master,Core,Task,Router,All
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 0:旧计费页面,1:新计费页面。 错填，默认为旧计费
        /// </summary>
        [JsonProperty("TradeType")]
        public ulong? TradeType{ get; set; }

        /// <summary>
        /// 产品Id，不填为0，则表示所有productId，前台使用必填
        /// 
        /// 44	EMR	V3.5.0
        /// 43	EMR	V3.4.0.tlinux
        /// 42	EMR	V2.7.0.tlinux
        /// 41	DRUID	V1.1.0
        /// 67	STARROCKS	V2.2.0
        /// 45	DRUID	V1.1.0.tlinux
        /// 40	EMRCLOUD	v3.2.0
        /// 47	EMR	V4.0.0
        /// 48	STARROCKS	V1.2.0
        /// 49	STARROCKS	V1.3.0
        /// 50	KAFKA	V2.0.0
        /// 51	STARROCKS	V1.4.0
        /// 52	EMR-TKE	V1.0.0
        /// 53	EMR	V3.6.0
        /// 54	STARROCKS	V2.0.0
        /// 55	EMR-TKE	V1.0.1
        /// 56	EMR-TKE	DLCV1.0.0
        /// 57	EMR	V2.8.0
        /// 58	EMR	V3.6.1
        /// 59	SERVERLESS	V1.0.0
        /// 60	EMR-TKE	V1.1.0
        /// 62	STARROCKS	V2.1.1
        /// 63	STARROCKS	V2.1.1.tlinux
        /// 64	EMR-TKE	TCCV1.0.0
        /// 65	EMR-TKE-AI	V1.0.0
        /// 66	RSS	V1.0.0
        /// 24	EMR	TianQiong-V1.0.0
        /// 3	EMR	V2.0.1.tlinux
        /// 4	EMR	V2.1.0
        /// 7	EMR	V3.0.0
        /// 8	EMR	V3.0.0.tlinux
        /// 9	EMR	V2.2.0
        /// 11	CLICKHOUSE	V1.0.0
        /// 12	CLICKHOUSE	V1.0.0.tlinux
        /// 16	EMR	V2.3.0
        /// 17	CLICKHOUSE	V1.1.0
        /// 18	CLICKHOUSE	V1.1.0.tlinux
        /// 19	EMR	V2.4.0
        /// 20	EMR	V2.5.0
        /// 21	USERCUSTOM	V1.0.0
        /// 22	CLICKHOUSE	V1.2.0
        /// 39	STARROCKS	V1.1.0
        /// 25	EMR	V3.1.0
        /// 26	DORIS	V1.0.0
        /// 27	KAFKA	V1.0.0
        /// 28	EMR	V3.2.0
        /// 29	EMR	V2.5.1
        /// 30	EMR	V2.6.0
        /// 32	DORIS	V1.1.0
        /// 33	EMR	V3.2.1
        /// 34	EMR	V3.3.0
        /// 35	DORIS	V1.2.0
        /// 36	STARROCKS	V1.0.0
        /// 37	EMR	V3.4.0
        /// 38	EMR	V2.7.0
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// 场景名
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 类型为ComputeResource和EMR以及默认，默认为EMR
        /// </summary>
        [JsonProperty("ResourceBaseType")]
        public string ResourceBaseType{ get; set; }

        /// <summary>
        /// 计算资源id
        /// </summary>
        [JsonProperty("ComputeResourceId")]
        public string ComputeResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "CvmPayMode", this.CvmPayMode);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "ResourceBaseType", this.ResourceBaseType);
            this.SetParamSimple(map, prefix + "ComputeResourceId", this.ComputeResourceId);
        }
    }
}

