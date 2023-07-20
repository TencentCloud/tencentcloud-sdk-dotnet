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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineDto : AbstractModel
    {
        
        /// <summary>
        /// 基线id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 基线名称
        /// </summary>
        [JsonProperty("BaselineName")]
        public string BaselineName{ get; set; }

        /// <summary>
        /// 天基线/小时基线
        /// </summary>
        [JsonProperty("BaselineType")]
        public string BaselineType{ get; set; }

        /// <summary>
        /// 基线创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 保障任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromiseTasks")]
        public BaselineTaskDto[] PromiseTasks{ get; set; }

        /// <summary>
        /// 告警规则
        /// </summary>
        [JsonProperty("AlarmRule")]
        public AlarmRuleDto AlarmRule{ get; set; }

        /// <summary>
        /// 基线状态，待提交, 运行中，停止
        /// </summary>
        [JsonProperty("BaselineStatus")]
        public string BaselineStatus{ get; set; }

        /// <summary>
        /// 最新基线实例运行状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestBaselineInstanceStatus")]
        public string LatestBaselineInstanceStatus{ get; set; }

        /// <summary>
        /// 预警余量/单位分钟
        /// </summary>
        [JsonProperty("WarningMargin")]
        public long? WarningMargin{ get; set; }

        /// <summary>
        /// 承诺时间
        /// </summary>
        [JsonProperty("PromiseTime")]
        public string PromiseTime{ get; set; }

        /// <summary>
        /// 责任人uin
        /// </summary>
        [JsonProperty("InChargeUin")]
        public string InChargeUin{ get; set; }

        /// <summary>
        /// 责任人名称
        /// </summary>
        [JsonProperty("InChargeName")]
        public string InChargeName{ get; set; }

        /// <summary>
        /// 当前用户uin
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 当前用户名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 主账号uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "BaselineName", this.BaselineName);
            this.SetParamSimple(map, prefix + "BaselineType", this.BaselineType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "PromiseTasks.", this.PromiseTasks);
            this.SetParamObj(map, prefix + "AlarmRule.", this.AlarmRule);
            this.SetParamSimple(map, prefix + "BaselineStatus", this.BaselineStatus);
            this.SetParamSimple(map, prefix + "LatestBaselineInstanceStatus", this.LatestBaselineInstanceStatus);
            this.SetParamSimple(map, prefix + "WarningMargin", this.WarningMargin);
            this.SetParamSimple(map, prefix + "PromiseTime", this.PromiseTime);
            this.SetParamSimple(map, prefix + "InChargeUin", this.InChargeUin);
            this.SetParamSimple(map, prefix + "InChargeName", this.InChargeName);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

