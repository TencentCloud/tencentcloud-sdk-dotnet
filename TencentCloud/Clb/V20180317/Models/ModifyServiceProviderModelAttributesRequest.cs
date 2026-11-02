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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyServiceProviderModelAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>BYOK 实例 ID</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>待修改的模型的名称（原始模型名称）</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>该模型支持的输入多模态能力列表</p><p>枚举值：</p><ul><li>text： 支持文本输入</li><li>image： 支持图像输入</li><li>file： 支持文件输入（当前仅支持pdf）</li><li>video： 支持视频输入</li></ul>
        /// </summary>
        [JsonProperty("InputModalities")]
        public string[] InputModalities{ get; set; }

        /// <summary>
        /// <p>新的上游模型名称</p>
        /// </summary>
        [JsonProperty("NewModelName")]
        public string NewModelName{ get; set; }

        /// <summary>
        /// <p>新的对外模型名称</p>
        /// </summary>
        [JsonProperty("NewModelAlias")]
        public string NewModelAlias{ get; set; }

        /// <summary>
        /// <p>上游模型灰度操作，支持 Set、Promote、Rollback。</p><p>入参限制：未传时沿用普通属性编辑；显式 null、空对象及未知字段拒绝。与显式传入的 NewModelName、NewModelAlias、InputModalities 互斥，包括 null 和空别名。</p><p>Set 必须提供候选 ModelName 和 1～99 的整数 Weight，可调整同一候选的比例；相同配置在资源可编辑时成功且不重复下发。Promote、Rollback 仅传 Operation，分别全量切换到候选或恢复主模型并结束灰度。外层 ModelName 定位当前主模型；响应仍为 RequestId，任务通过 DescribeAsyncJobs 查询。</p>
        /// </summary>
        [JsonProperty("UpstreamRollout")]
        public UpstreamRolloutOperation UpstreamRollout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamArraySimple(map, prefix + "InputModalities.", this.InputModalities);
            this.SetParamSimple(map, prefix + "NewModelName", this.NewModelName);
            this.SetParamSimple(map, prefix + "NewModelAlias", this.NewModelAlias);
            this.SetParamObj(map, prefix + "UpstreamRollout.", this.UpstreamRollout);
        }
    }
}

