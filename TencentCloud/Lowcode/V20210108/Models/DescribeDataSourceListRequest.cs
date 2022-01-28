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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataSourceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 环境 id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 应用id数组
        /// </summary>
        [JsonProperty("Appids")]
        public string[] Appids{ get; set; }

        /// <summary>
        /// 数据源id数组
        /// </summary>
        [JsonProperty("DataSourceIds")]
        public string[] DataSourceIds{ get; set; }

        /// <summary>
        /// 数据源名称数组
        /// </summary>
        [JsonProperty("DataSourceNames")]
        public string[] DataSourceNames{ get; set; }

        /// <summary>
        /// 数据源类型 database-自建数据源；cloud-integration-自定义数据源
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// 数据源模糊查询参数
        /// </summary>
        [JsonProperty("QueryOption")]
        public DataSourceQueryOption QueryOption{ get; set; }

        /// <summary>
        /// 数据源视图Id数组
        /// </summary>
        [JsonProperty("ViewIds")]
        public string[] ViewIds{ get; set; }

        /// <summary>
        /// 查询未关联应用的数据源，0:未关联，该参数配合 AppIds 参数一块使用
        /// </summary>
        [JsonProperty("AppLinkStatus")]
        public long? AppLinkStatus{ get; set; }

        /// <summary>
        /// 查询应用绑定数据源: 0: 否,1: 是
        /// </summary>
        [JsonProperty("QueryBindToApp")]
        public long? QueryBindToApp{ get; set; }

        /// <summary>
        /// 查询连接器 0 数据模型 1 连接器 2 自定义连接器
        /// </summary>
        [JsonProperty("QueryConnector")]
        public long? QueryConnector{ get; set; }

        /// <summary>
        /// 查询数据源黑名单机制，比如不想要系统数据源["system"]
        /// </summary>
        [JsonProperty("NotQuerySubTypeList")]
        public string[] NotQuerySubTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamArraySimple(map, prefix + "Appids.", this.Appids);
            this.SetParamArraySimple(map, prefix + "DataSourceIds.", this.DataSourceIds);
            this.SetParamArraySimple(map, prefix + "DataSourceNames.", this.DataSourceNames);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamObj(map, prefix + "QueryOption.", this.QueryOption);
            this.SetParamArraySimple(map, prefix + "ViewIds.", this.ViewIds);
            this.SetParamSimple(map, prefix + "AppLinkStatus", this.AppLinkStatus);
            this.SetParamSimple(map, prefix + "QueryBindToApp", this.QueryBindToApp);
            this.SetParamSimple(map, prefix + "QueryConnector", this.QueryConnector);
            this.SetParamArraySimple(map, prefix + "NotQuerySubTypeList.", this.NotQuerySubTypeList);
        }
    }
}

