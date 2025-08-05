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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataSourceInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 过滤条件（暂不支持）
        /// </summary>
        [JsonProperty("Filters")]
        public Filter Filters{ get; set; }

        /// <summary>
        /// 排序配置
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField OrderFields{ get; set; }

        /// <summary>
        /// 数据源类型，MYSQL,TENCENT_MYSQL,TDSQL_MYSQL,HIVE,KAFKA,POSTGRE,CDW,ORACLE,SQLSERVER,FTP,HDFS,ICEBERG,HBASE,TDSQL,TDSQLC,SPARK,VIRTUAL,TBASE,DB2,DM,TDENGINE,GAUSSDB,GBASE,IMPALA,ES,TENCENT_ES,S3_DATAINSIGHT,GREENPLUM,PHOENIX,SAP_HANA,SFTP,OCEANBASE,CLICKHOUSE,TCHOUSE_C,KUDU,VERTICA,REDIS,COS,S3,DLC,DORIS,CKAFKA,TDMQ_PULSAR,MONGODB,TENCENT_MONGODB,FTP_FILE,HDFS_FILE,DTS_KAFKA,REST_API,FILE,TIDB,SYBASE,TCHOUSE_X,TDSQL_POSTGRE,TCHOUSE_P,TCHOUSE_D,STARROCKS,EMR_STARROCKS,TBDS_STARROCKS,TRINO,KYUUBI,GDB,INFLUXDB,BIG_QUERY,BLOB,FILESYSTEM,SHAREPOINT,KINGBASEES,HUDI等
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数据源名称过滤
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
        }
    }
}

