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

    public class DescribeMigrationJobsRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据迁移任务ID，如：dts-amm1jw5q
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 数据迁移任务名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 数据迁移任务状态，可取值包括：created(创建完成)、checking(校验中)、checkPass(校验通过)、checkNotPass(校验不通过)、readyRun(准备运行)、running(任务运行中)、readyComplete(准备完成)、success(任务成功)、failed(任务失败)、stopping(中止中)、completing(完成中)
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 源实例ID，格式如：cdb-c1nl9rpv
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// 源实例地域，如：ap-guangzhou
        /// </summary>
        [JsonProperty("SrcRegion")]
        public string SrcRegion{ get; set; }

        /// <summary>
        /// 源实例数据库类型，如：sqlserver,mysql,mongodb,redis,tendis,keewidb,clickhouse,cynosdbmysql,percona,tdsqlpercona,mariadb,tdsqlmysql,postgresql
        /// </summary>
        [JsonProperty("SrcDatabaseType")]
        public string[] SrcDatabaseType{ get; set; }

        /// <summary>
        /// 源实例接入类型，值包括：extranet(外网)、vpncloud(云vpn接入的实例)、dcg(专线接入的实例)、ccn(云联网接入的实例)、cdb(云上cdb实例)、cvm(cvm自建实例)
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string[] SrcAccessType{ get; set; }

        /// <summary>
        /// 目标实例ID，格式如：cdb-c1nl9rpv
        /// </summary>
        [JsonProperty("DstInstanceId")]
        public string DstInstanceId{ get; set; }

        /// <summary>
        /// 目标实例地域，如：ap-guangzhou
        /// </summary>
        [JsonProperty("DstRegion")]
        public string DstRegion{ get; set; }

        /// <summary>
        /// 目标源实例数据库类型，如：sqlserver,mysql,mongodb,redis,tendis,keewidb,clickhouse,cynosdbmysql,percona,tdsqlpercona,mariadb,tdsqlmysql,postgresql
        /// </summary>
        [JsonProperty("DstDatabaseType")]
        public string[] DstDatabaseType{ get; set; }

        /// <summary>
        /// 目标实例接入类型，值包括：extranet(外网)、vpncloud(云vpn接入的实例)、dcg(专线接入的实例)、ccn(云联网接入的实例)、cdb(云上cdb实例)、cvm(cvm自建实例)
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string[] DstAccessType{ get; set; }

        /// <summary>
        /// 任务运行模式，值包括：immediate(立即运行)，timed(定时运行)
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// 排序方式，可能取值为asc、desc，默认按照创建时间倒序
        /// </summary>
        [JsonProperty("OrderSeq")]
        public string OrderSeq{ get; set; }

        /// <summary>
        /// 返回实例数量，默认20，有效区间[1,100]
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 标签过滤
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "SrcRegion", this.SrcRegion);
            this.SetParamArraySimple(map, prefix + "SrcDatabaseType.", this.SrcDatabaseType);
            this.SetParamArraySimple(map, prefix + "SrcAccessType.", this.SrcAccessType);
            this.SetParamSimple(map, prefix + "DstInstanceId", this.DstInstanceId);
            this.SetParamSimple(map, prefix + "DstRegion", this.DstRegion);
            this.SetParamArraySimple(map, prefix + "DstDatabaseType.", this.DstDatabaseType);
            this.SetParamArraySimple(map, prefix + "DstAccessType.", this.DstAccessType);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "OrderSeq", this.OrderSeq);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

