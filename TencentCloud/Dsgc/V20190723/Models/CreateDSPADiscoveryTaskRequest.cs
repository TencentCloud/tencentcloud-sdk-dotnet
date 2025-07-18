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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDSPADiscoveryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 任务名称，1-60个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字，Name不可重复
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 任务开关，0 关闭，1 启用
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 执行计划， 0立即 1定时，选择“立即”时，扫描周期只能选择单次
        /// </summary>
        [JsonProperty("Plan")]
        public long? Plan{ get; set; }

        /// <summary>
        /// 扫描周期，0单次 1每天 2每周 3每月
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 资源所在地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 数据源类型，可取值如下：
        /// cdb 表示云数据库 MySQL,
        /// dcdb 表示TDSQL MySQL版,
        /// mariadb 表示云数据库 MariaDB,
        /// postgres 表示云数据库 PostgreSQL,
        /// cynosdbpg 表示TDSQL-C PostgreSQL版,
        /// cynosdbmysql 表示TDSQL-C MySQL版,
        /// selfbuilt-db 表示自建数据库
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// 通用规则集开关，0 关闭，1 启用
        /// </summary>
        [JsonProperty("GeneralRuleSetEnable")]
        [System.Obsolete]
        public long? GeneralRuleSetEnable{ get; set; }

        /// <summary>
        /// 任务描述，最大长度为1024个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 用于传入的数据源的条件，目前只支持数据库，所以目前表示数据库的名称，选择多个数据库，之间通过逗号分隔，若不选，则默认选择全部数据库
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 合规组ID列表，最多支持添加5个
        /// </summary>
        [JsonProperty("ComplianceGroupIds")]
        public long?[] ComplianceGroupIds{ get; set; }

        /// <summary>
        /// 任务定时启动时间，格式如：2006-01-02 15:04:05
        /// 当执行计划（Plan字段）为”立即“时，定时启动时间不会生效，此场景下给该字段传值不会被保存。
        /// </summary>
        [JsonProperty("TimingStartTime")]
        public string TimingStartTime{ get; set; }

        /// <summary>
        /// random-随机，asc生序，desc降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 抽样的条数，范围30-1000
        /// </summary>
        [JsonProperty("Rows")]
        public long? Rows{ get; set; }

        /// <summary>
        /// 抽样的排序字段
        /// </summary>
        [JsonProperty("GlobalOrderField")]
        public string GlobalOrderField{ get; set; }

        /// <summary>
        /// full:全量扫描 incre:变更扫描
        /// </summary>
        [JsonProperty("ScanRange")]
        public string ScanRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Plan", this.Plan);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamSimple(map, prefix + "GeneralRuleSetEnable", this.GeneralRuleSetEnable);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamArraySimple(map, prefix + "ComplianceGroupIds.", this.ComplianceGroupIds);
            this.SetParamSimple(map, prefix + "TimingStartTime", this.TimingStartTime);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Rows", this.Rows);
            this.SetParamSimple(map, prefix + "GlobalOrderField", this.GlobalOrderField);
            this.SetParamSimple(map, prefix + "ScanRange", this.ScanRange);
        }
    }
}

