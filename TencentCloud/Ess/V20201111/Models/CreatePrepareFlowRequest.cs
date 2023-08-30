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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePrepareFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 资源id，与ResourceType对应
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 是否顺序签署
        /// true:无序签
        /// false:顺序签
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 签署流程的签署截止时间。
        /// 值为unix时间戳,精确到秒
        /// 不传默认为当前时间一年后
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 用户自定义合同类型Id
        /// 
        /// 该id为电子签企业内的合同类型id， 可以在自定义合同类型处获取
        /// </summary>
        [JsonProperty("UserFlowTypeId")]
        public string UserFlowTypeId{ get; set; }

        /// <summary>
        /// 合同类型名称
        /// 该字段用于客户自定义合同类型
        /// 建议使用时指定合同类型，便于之后合同分类以及查看
        /// 如果合同类型与自定义的合同类型描述一致，会自动归类到自定义的合同类型处，如果不一致，则会创建一个新的自定义合同类型
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 签署流程参与者信息，最大限制50方
        /// </summary>
        [JsonProperty("Approvers")]
        public FlowCreateApprover[] Approvers{ get; set; }

        /// <summary>
        /// 打开智能添加填写区
        /// 默认开启，打开:"OPEN"
        ///  关闭："CLOSE"
        /// </summary>
        [JsonProperty("IntelligentStatus")]
        public string IntelligentStatus{ get; set; }

        /// <summary>
        /// 资源类型，
        /// 1：模板
        /// 2：文件，
        /// 不传默认为2：文件
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// 发起方填写控件
        /// 该类型控件由发起方完成填写
        /// </summary>
        [JsonProperty("Components")]
        public Component Components{ get; set; }

        /// <summary>
        /// 发起合同个性化参数
        /// 用于满足创建及页面操作过程中的个性化要求
        /// 具体定制化内容详见数据接口说明
        /// </summary>
        [JsonProperty("FlowOption")]
        public CreateFlowOption FlowOption{ get; set; }

        /// <summary>
        /// 是否开启发起方签署审核
        /// true:开启发起方签署审核
        /// false:不开启发起方签署审核
        /// 默认false:不开启发起方签署审核
        /// </summary>
        [JsonProperty("NeedSignReview")]
        public bool? NeedSignReview{ get; set; }

        /// <summary>
        /// 开启发起方发起合同审核
        /// true:开启发起方发起合同审核
        /// false:不开启发起方发起合同审核
        /// 默认false:不开启发起方发起合同审核
        /// </summary>
        [JsonProperty("NeedCreateReview")]
        public bool? NeedCreateReview{ get; set; }

        /// <summary>
        /// 用户自定义参数
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 合同id,用于通过已web页面发起的合同id快速生成一个web发起合同链接
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填	
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "UserFlowTypeId", this.UserFlowTypeId);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "IntelligentStatus", this.IntelligentStatus);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamObj(map, prefix + "Components.", this.Components);
            this.SetParamObj(map, prefix + "FlowOption.", this.FlowOption);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
            this.SetParamSimple(map, prefix + "NeedCreateReview", this.NeedCreateReview);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

