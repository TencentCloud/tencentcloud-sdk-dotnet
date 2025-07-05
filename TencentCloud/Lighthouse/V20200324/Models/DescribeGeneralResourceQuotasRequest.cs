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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGeneralResourceQuotasRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源名列表，可取值:
        /// - GENERAL_BUNDLE_INSTANCE 通用型套餐实例
        /// - STORAGE_BUNDLE_INSTANCE 存储型套餐实例 
        /// - ENTERPRISE_BUNDLE_INSTANCE 企业型套餐实例 
        /// - EXCLUSIVE_BUNDLE_INSTANCE 专属型套餐实例
        /// - BEFAST_BUNDLE_INSTANCE 蜂驰型套餐实例
        /// - STARTER_BUNDLE_INSTANCE 入门型套餐实例
        /// - HK_EXCLUSIVE_BUNDLE_INSTANCE 中国香港专属型套餐实例
        /// - CAREFREE_BUNDLE_INSTANCE 无忧型套餐实例
        /// - USER_KEY_PAIR 密钥对
        /// - SNAPSHOT 快照
        /// - BLUEPRINT 自定义镜像
        /// - FREE_BLUEPRINT 免费自定义镜像
        /// - DATA_DISK 数据盘
        /// </summary>
        [JsonProperty("ResourceNames")]
        public string[] ResourceNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceNames.", this.ResourceNames);
        }
    }
}

