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

    public class RerunScheduleInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例列表
        /// </summary>
        [JsonProperty("Instances")]
        public InstanceOpsDto[] Instances{ get; set; }

        /// <summary>
        /// 检查父任务类型, true: 检查父任务; false: 不检查父任务 
        /// </summary>
        [JsonProperty("CheckFather")]
        public bool? CheckFather{ get; set; }

        /// <summary>
        /// 重跑类型, 1: 自身; 3: 孩子; 2: 自身以及孩子 
        /// </summary>
        [JsonProperty("RerunType")]
        public string RerunType{ get; set; }

        /// <summary>
        /// 实例依赖方式, 1: 自依赖; 2: 任务依赖; 3: 自依赖及父子依赖 
        /// </summary>
        [JsonProperty("DependentWay")]
        public string DependentWay{ get; set; }

        /// <summary>
        /// 重跑忽略事件监听与否 
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// 下游实例范围 1: 所在工作流 2: 所在项目 3: 所有跨工作流依赖的项目
        /// </summary>
        [JsonProperty("SonInstanceType")]
        public string SonInstanceType{ get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonProperty("SearchCondition")]
        public InstanceApiOpsRequest SearchCondition{ get; set; }

        /// <summary>
        /// 访问类型
        /// </summary>
        [JsonProperty("OptType")]
        public string OptType{ get; set; }

        /// <summary>
        /// 操作者名称
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目标志
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 索引页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 基础请求信息
        /// </summary>
        [JsonProperty("RequestBaseInfo")]
        public ProjectBaseInfoOpsRequest RequestBaseInfo{ get; set; }

        /// <summary>
        /// 是否计算总数
        /// </summary>
        [JsonProperty("IsCount")]
        public bool? IsCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "CheckFather", this.CheckFather);
            this.SetParamSimple(map, prefix + "RerunType", this.RerunType);
            this.SetParamSimple(map, prefix + "DependentWay", this.DependentWay);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "SonInstanceType", this.SonInstanceType);
            this.SetParamObj(map, prefix + "SearchCondition.", this.SearchCondition);
            this.SetParamSimple(map, prefix + "OptType", this.OptType);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "OperatorId", this.OperatorId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamObj(map, prefix + "RequestBaseInfo.", this.RequestBaseInfo);
            this.SetParamSimple(map, prefix + "IsCount", this.IsCount);
        }
    }
}

