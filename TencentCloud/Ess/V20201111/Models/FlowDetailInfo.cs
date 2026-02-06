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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同流程的名称（可自定义此名称），长度不能超过200，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同流程的类别分类（如销售合同/入职合同等）。
        /// 该字段将被废弃，不建议使用。	
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 合同流程当前的签署状态, 会存在下列的状态值 
        /// <ul>
        /// <li> **0** : 未开启流程(合同中不存在填写环节)</li> 
        /// <li> **1** : 待签署</li>
        ///  <li> **2** : 部分签署</li>
        ///  <li> **3** : 已拒签</li>
        ///  <li> **4** : 已签署</li> 
        /// <li> **5** : 已过期</li>
        ///  <li> **6** : 已撤销</li> 
        /// <li> **7** : 未开启流程(合同中存在填写环节)</li>
        ///  <li> **8** : 等待填写</li>
        ///  <li> **9** : 部分填写</li>
        ///  <li> **10** : 已拒填</li> 
        /// <li> **16** : 已失效（可能因为参与方修改姓名等原因）</li>
        ///  <li> **21** : 已解除</li></ul>	
        /// </summary>
        [JsonProperty("FlowStatus")]
        public long? FlowStatus{ get; set; }

        /// <summary>
        /// 当合同流程状态为已拒签（即 FlowStatus=3）或已撤销（即 FlowStatus=6）时，此字段 FlowMessage 为拒签或撤销原因。	
        /// </summary>
        [JsonProperty("FlowMessage")]
        public string FlowMessage{ get; set; }

        /// <summary>
        /// 合同流程描述信息。	
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 合同流程的创建时间戳，格式为Unix标准时间戳（秒）。	
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 合同流程的签署方数组
        /// </summary>
        [JsonProperty("FlowApproverInfos")]
        public FlowApproverDetail[] FlowApproverInfos{ get; set; }

        /// <summary>
        /// 合同流程的关注方信息数组
        /// </summary>
        [JsonProperty("CcInfos")]
        public FlowApproverDetail[] CcInfos{ get; set; }

        /// <summary>
        /// 合同流程发起方的员工编号, 即员工在腾讯电子签平台的唯一身份标识。	
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 用户合同的自定义分类。
        /// 
        /// 自定义合同类型的位置，在下图所示地方:
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/00d72934c31bd49115a566e4e1a4530d.png)
        /// </summary>
        [JsonProperty("UserFlowType")]
        public UserFlowType UserFlowType{ get; set; }

        /// <summary>
        /// 发起模板时,使用的模板Id
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "FlowStatus", this.FlowStatus);
            this.SetParamSimple(map, prefix + "FlowMessage", this.FlowMessage);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamArrayObj(map, prefix + "FlowApproverInfos.", this.FlowApproverInfos);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamObj(map, prefix + "UserFlowType.", this.UserFlowType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

