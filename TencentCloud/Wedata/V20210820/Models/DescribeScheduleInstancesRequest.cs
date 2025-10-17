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

    public class DescribeScheduleInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求来源，WEB 前端；CLIENT 客户端
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 实例列表过滤条件
        /// </summary>
        [JsonProperty("Instances")]
        public InstanceOpsDto[] Instances{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 检查父任务类型,  true: 检查父任务类型;  false: 不检查父任务类型
        /// </summary>
        [JsonProperty("CheckFather")]
        public bool? CheckFather{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 重跑类型, 1: 仅重跑当前实例; 2: 重跑当前实例及其子实例; 3: 仅重跑子实例
        /// </summary>
        [JsonProperty("RerunType")]
        public string RerunType{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 实例依赖方式, 1: 任务自依赖; 2: 任务上游依赖; 3: 自依赖及其上游依赖 
        /// </summary>
        [JsonProperty("DependentWay")]
        public string DependentWay{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 重跑时是否忽略事件监听
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
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
        /// 【已废弃参数，新用户接入无需关注】
        /// 访问类型
        /// </summary>
        [JsonProperty("OptType")]
        public string OptType{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 操作者名称
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 操作者id
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 【必要参数】
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 【必要参数】
        /// 分页查询开始页页码，默认值为 1
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 【必要参数】
        /// 分页查询每页返回的结果行数，默认值为 10
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 数据总数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 基础请求信息
        /// </summary>
        [JsonProperty("RequestBaseInfo")]
        public ProjectBaseInfoOpsRequest RequestBaseInfo{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 是否计算总数
        /// </summary>
        [JsonProperty("IsCount")]
        public bool? IsCount{ get; set; }

        /// <summary>
        /// 【已废弃参数，新用户接入无需关注】
        /// 项目ID列表，用于多项目实例列表筛选，请注意，该字段传入时 ProjectId 字段也必须传，且传入的 ProjectIds 中的项目ID必须是当前用户有权限的项目ID，否则会由于权限校验失败报错
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
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
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
        }
    }
}

