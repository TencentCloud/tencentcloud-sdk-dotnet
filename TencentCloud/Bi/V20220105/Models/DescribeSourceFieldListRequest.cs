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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSourceFieldListRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源Id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public long? DataSourceId{ get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// sql内容
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 是否是异步
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// 异步事务id
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamCreateDTO[] ParamList{ get; set; }

        /// <summary>
        /// DLC扩展参数
        /// </summary>
        [JsonProperty("DlcExtInfo")]
        public string DlcExtInfo{ get; set; }

        /// <summary>
        /// 是否查询数据库
        /// </summary>
        [JsonProperty("QueryDbData")]
        public string QueryDbData{ get; set; }

        /// <summary>
        /// 数据表 Id
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 后端提供字典：数据表类型，1、数据库建表，2、SQL建表，3、Excel上传，4、API接入，5、腾讯文档，6、云数据库，7、手工输入，8、关联查询
        /// </summary>
        [JsonProperty("TableType")]
        public ulong? TableType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "DlcExtInfo", this.DlcExtInfo);
            this.SetParamSimple(map, prefix + "QueryDbData", this.QueryDbData);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
        }
    }
}

