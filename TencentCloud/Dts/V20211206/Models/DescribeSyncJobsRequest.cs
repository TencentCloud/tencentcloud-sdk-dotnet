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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSyncJobsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>同步任务id，如sync-werwfs23，可通过<a href="https://cloud.tencent.com/document/product/571/82103">DescribeSyncJobs</a>接口获取。</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>同步任务id列表，如[&quot;sync-n3gh7md9&quot;]</p>
        /// </summary>
        [JsonProperty("JobIds")]
        public string[] JobIds{ get; set; }

        /// <summary>
        /// <p>同步任务名</p>
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// <p>排序字段，目前仅支持CreateTime字段排序</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>排序方式，升序为ASC，降序为DESC，默认为CreateTime降序</p>
        /// </summary>
        [JsonProperty("OrderSeq")]
        public string OrderSeq{ get; set; }

        /// <summary>
        /// <p>偏移量，默认为0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>返回同步任务实例数量，默认20，有效区间[1,100]</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>状态集合，如Initialized(初始化),CheckPass(校验通过),Running(运行中),ResumableErr(恢复中),Stopped(已结束)</p>
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// <p>运行模式，如Immediate:立即运行，Timed:定时运行</p>
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// <p>任务类型，如mysql2mysql：msyql同步到mysql;可取值有mysql2mysql、mysql2kafka、tdsqlmysql2kafka、tdsqlmysql2tdsqlmysql、tdsqlmysql2mysql、mysql2tdsqlmysql、mysql2mariadb、mariadb2mariadb、mariadb2kafka、cynosdbmysql2kafka、cynosdbmysql2cynosdbmysql、cynosdbmysql2mysql、mysql2cynosdbmysql、mariadb2tdsqlmysql、tdsqlmysql2cynosdbmysql、cynosdbmysql2tdsqlmysql、tdstore2mysql、tdstore2percona、tdstore2mariadb、tdstore2cynosdbmysql、cynosdbmysql2mariadb、mariadb2cynosdbmysql、tdsqlmysql2mariadb、mariadb2mysql、percona2mariadb、postgresql2postgresql、tdstore2tdsqlmysql、mongodb2mongodb</p>
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// <p>付费类型，PrePay：预付费，PostPay：后付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>tag</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// <p>源端数据库连接信息，可以输入实例ID或者IP等</p>
        /// </summary>
        [JsonProperty("SrcInfoPattern")]
        public string SrcInfoPattern{ get; set; }

        /// <summary>
        /// <p>目标端数据库连接信息，可以输入实例ID或者IP等</p>
        /// </summary>
        [JsonProperty("DstInfoPattern")]
        public string DstInfoPattern{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamArraySimple(map, prefix + "JobIds.", this.JobIds);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderSeq", this.OrderSeq);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamSimple(map, prefix + "SrcInfoPattern", this.SrcInfoPattern);
            this.SetParamSimple(map, prefix + "DstInfoPattern", this.DstInfoPattern);
        }
    }
}

